using Microsoft.AspNetCore.Mvc;


using Microsoft.AspNetCore.Mvc;
using MobilePriceWeb.Models;
using MobilePricePrediction1;

namespace MobilePriceWeb.Controllers
{
    public class PredictionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PredictionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var input = new MLModel1.ModelInput
            {
                Battery_power = model.Battery_power,
                Blue = model.Blue,
                Clock_speed = model.Clock_speed,
                Dual_sim = model.Dual_sim,
                Fc = model.Fc,
                Four_g = model.Four_g,
                Int_memory = model.Int_memory,
                M_dep = model.M_dep,
                Mobile_wt = model.Mobile_wt,
                N_cores = model.N_cores,
                Pc = model.Pc,
                Px_height = model.Px_height,
                Px_width = model.Px_width,
                Ram = model.Ram,
                Sc_h = model.Sc_h,
                Sc_w = model.Sc_w,
                Talk_time = model.Talk_time,
                Three_g = model.Three_g,
                Touch_screen = model.Touch_screen,
                Wifi = model.Wifi
            };

            var prediction = MLModel1.Predict(input);

            model.Result = $"Predicted price range: {prediction.PredictedLabel}";

            return View(model);
        }
    }
}