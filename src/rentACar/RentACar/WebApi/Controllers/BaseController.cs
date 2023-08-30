using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class BaseController:ControllerBase
{
    private IMediator _mediatr;
    protected IMediator Mediator=>_mediatr??=HttpContext.RequestServices.GetRequiredService<IMediator>();
}
