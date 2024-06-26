﻿using MediatR;
using MetroDelivery.Application.Features.Route_Stations.Queries;
using MetroDelivery.Application.Features.Route_Stations.Queries.GetAllRouteStation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Route_Stations
{
    [Route("api/v1/route-station")]
    [ApiController]
    public class RouteStationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RouteStationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<RouteStationResponse>> Get()
        {
            var response = await _mediator.Send(new GetListRouteStationQuery());
            return response;
        }

        
    }
}
