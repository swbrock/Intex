//using System;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Mvc;

//namespace Intex.Components
//{
//    public class TypesViewComponent : ViewComponent
//    {
//        private ITeamsRepository repoT { get; set; }
//        public TypesViewComponent(ITeamsRepository tempT)
//        {
//            repoT = tempT;
//        }

//        public async Task<IViewComponentResult> InvokeAsync()
//        {
//            ViewBag.SelectedType = RouteData?.Values["county"];

//            var types = repoT.Teams
//                .Select(x => x.TeamName)
//                .Distinct()
//                .OrderBy(x => x);
//            return View(types);
//        }
//    }
//}
