using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyECommerce.Core.Entities;
using MyECommerce.Core.Interfaces;
using MyECommerce.Infrastructure.Data;
using System;

namespace MyECommerce.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IConfiguration _config;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signManager;
        private readonly ILogger<UserService> _logger;

        private readonly AppDbContext _dataContext;

        public UserService(IConfiguration configuration, IServiceProvider serviceProvider, ILogger<UserService> logger, AppDbContext dataContext)
        {
            _config = configuration;
            _logger = logger;
            _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            _userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            _signManager = serviceProvider.GetRequiredService<SignInManager<User>>();
            _dataContext = dataContext;
        }
    }
}