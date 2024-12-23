using BoatNavigation_RouteService.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BoatNavigation_RouteService.API.Controllers
{
    /// <summary>
    /// Контроллер управления автономными маршрутами
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        /// <summary>
        /// Получение всех маршуртов
        /// </summary>
        /// <returns>Список маршрутов</returns>
        [HttpGet]
        public ActionResult GetRoutes()
        {
            var routes = new List<NavigationRoute>();

            return Ok(routes);
        }

        /// <summary>
        /// Получение маршрута по id
        /// </summary>
        /// <param name="id">Id маршрута</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult GetRoute(Guid id)
        {
            return Ok();
        }
    }
}
