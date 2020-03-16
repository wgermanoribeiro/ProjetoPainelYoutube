using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPainelYoutube.Components
{
    [ViewComponent(Name = "Youtube2ViewComponent")]
    public class Youtube2ViewComponent : ViewComponent
    {       
        
        public string Link2 { get; set; }

        public Youtube2ViewComponent()
        {            
            Link2 = "https://www.youtube.com/watch?v=IwzUs1IMdyQ";            
        }     
        

        public IViewComponentResult Invoke()
        {
            Youtube2ViewComponent componentYoutube = new Youtube2ViewComponent();
            return View(componentYoutube);
        }
    }
}
