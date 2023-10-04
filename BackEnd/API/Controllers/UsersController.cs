using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using DataAccess.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
// [Authorize]
public class UsersController : BaseController<User>
{
    public UsersController(ApplicationDbContext context, ILogger<BaseController<User>> logger) : base(context, logger)
    {

    }

  
     
}