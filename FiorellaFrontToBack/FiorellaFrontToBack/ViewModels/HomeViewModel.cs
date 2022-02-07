using FiorellaFrontToBack.Models;
using System.Collections.Generic;

namespace FiorellaFrontToBack.ViewModels
{
    public class HomeViewModel
    {
        public List<AboutSectionServices> AboutServices { get; set; }
        public AboutSection AboutSection { get; set; }
        public ExpertSection ExpertSection { get; set; }
        public List<Expert> Experts { get; set; }
        public Subscribe Subscribes { get; set; }
    }
}
