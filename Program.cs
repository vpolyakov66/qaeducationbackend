using Microsoft.AspNetCore.HttpOverrides;
using qaeducationbackend.Dal.Repository;
using qaeducationbackend.Dal.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISessionRepository, SessionRepository>();


var app = builder.Build();

/*
if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}
*/

app.UseSwagger();

app.UseSwaggerUI();


//app.UseHttpsRedirection();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseAuthorization();

app.MapControllers();

{
    var sessionRepository = app.Services.GetRequiredService<ISessionRepository>();
    sessionRepository.SeedData();
}

app.Run();
