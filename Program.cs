using System;
using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;





var builder = WebApplication.CreateBuilder();
builder.Services.AddFastEndpoints();

var app = builder.Build();
app.UseFastEndpoints();
app.Run();

