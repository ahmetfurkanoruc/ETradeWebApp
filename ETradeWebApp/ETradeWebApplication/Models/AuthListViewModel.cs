using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETradeWebApplication.Models
{
    public class AuthListViewModel
    {
        public UserForLoginDto UserForLoginDto { get; set; }
        public UserForRegisterDto UserForRegisterDto { get; set; }

    }
}
