using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPainelYoutube.Components
{
    [ViewComponent(Name = "Youtube1ViewComponent")]
    public class Youtube1ViewComponent : ViewComponent
    {
        
        public string Link1 { get; set; }        

        public Youtube1ViewComponent()
        {            
            Link1 = "https://www.youtube.com/watch?v=Rv2tAF1CEP0";          
        }     
        

        public IViewComponentResult Invoke()
        {
            Youtube1ViewComponent componentYoutube = new Youtube1ViewComponent();
            return View(componentYoutube);
        }
    }
}
