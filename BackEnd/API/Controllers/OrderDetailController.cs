using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    public class OrderDetailController : BaseController<OrderDetail>
    {
        public OrderDetailController(ApplicationDbContext context, ILogger<BaseController<OrderDetail>> logger) : base(context, logger)
        {

        }


    }
}