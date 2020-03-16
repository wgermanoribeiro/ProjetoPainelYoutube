using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPainelYoutube.Components
{
    [ViewComponent(Name = "Google1ViewComponent")]
    public class Google1ViewComponent : ViewComponent
    {       
        
        public string Google1 { get; set; }

        public Google1ViewComponent()
        {            
            Google1 = "https://www.google.com.br/maps/dir/-22.1519571,-49.9469441/connectparts/@-22.1534808,-49.9554988,16z/data=!3m1!4b1!4m9!4m8!1m1!4e1!1m5!1m1!1s0x94bfd4190018da35:0x17855e99e3cf5f44!2m2!1d-49.9543994!2d-22.1573626";            
        }     
        

        public IViewComponentResult Invoke()
        {
            Google1ViewComponent componentYoutube = new Google1ViewComponent();
            return View(componentYoutube);
        }
    }
}
