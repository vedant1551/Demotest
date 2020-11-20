using Microsoft.AspNetCore.Identity;
using OnlineMedicineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineMedicineStore.Service;
using Microsoft.Extensions.Configuration;

namespace OnlineMedicineStore.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;

        //Registration
        public AccountRepository(UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager, 
            IUserService userService,
            IConfiguration configuration,
            IEmailService emailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
            _configuration = configuration;
            _emailService = emailService;
        }

        public async Task<ApplicationUser> GetUserByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }
        public async Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel)
        {
            var user = new ApplicationUser()
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                ContactNo = userModel.ContactNo,
                Email = userModel.Email,
                UserName = userModel.UserName,  
                PhoneNumber = userModel.ContactNo 
                
            };
           var result = await _userManager.CreateAsync(user, userModel.Password);
            return result;
        }

        //Login
        public async Task<SignInResult> PasswordSignInAsync(SignInUserModel signInModel)
        {
            return  await _signInManager.PasswordSignInAsync(signInModel.Email, signInModel.Password, signInModel.RememberMe, false);
        }

        //Logout

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        //Change Password

        public async Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel changePasswordModel)
        {
            var userId = _userService.GetUserId();
            var user = await _userManager.FindByIdAsync(userId);
            return await _userManager.ChangePasswordAsync(user,changePasswordModel.CurrentPassword,changePasswordModel.NewPassword);

        }

        //Create Token For Forgot Password

        public async Task GenerateForgotPasswordTokenAsync(ApplicationUser user)
        {
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            if (!string.IsNullOrEmpty(token))
            {
                await SendForgotPasswordEmail(user, token);
            }
        }

        private async Task SendForgotPasswordEmail(ApplicationUser user, string token)
        {
            string appDomain = _configuration.GetSection("Application:AppDomain").Value;
            string confirmationLink = _configuration.GetSection("Application:ForgotPassword").Value;

            UserEmailOptions options = new UserEmailOptions
            {
                ToEmails = new List<string>() { user.Email },
                PlaceHolders = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("{{UserName}}", user.FirstName),
                    new KeyValuePair<string, string>("{{Link}}",
                        string.Format(appDomain + confirmationLink, user.Id, token))
                }
            };

            await _emailService.SendEmailForForgotPassword(options);
        }

        public async Task<IdentityResult> ResetPasswordAsync(ResetPasswordModel model)
        {
            return await _userManager.ResetPasswordAsync(await _userManager.FindByIdAsync(model.UserId), model.Token, model.NewPassword);
        }

       /* private async Task GetUserAsync(ApplicationUser user)
        {
            var firstName = user.FirstName;
            var lastName = user.LastName;
            var phoneNumber = user.ContactNo;
            var email = user.Email;

            InputModel inputModel = new InputModel
            {
                FirstName = firstName,
                LastName = lastName,
                ContactNo = phoneNumber,
                Email = email
            };

            await _userService
        }*/

    }
}
