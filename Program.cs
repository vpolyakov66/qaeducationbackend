using Microsoft.AspNetCore.HttpOverrides;
using qaeducationbackend.Dal.Repository;
using qaeducationbackend.Dal.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
); ;

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISessionRepository, SessionRepository>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin();
            builder.AllowAnyHeader();
            builder.AllowAnyMethod();
        });
});

var app = builder.Build();

/*
if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}
*/

app.UseSwagger();

app.UseSwaggerUI();


app.UseCors(builder => builder
.AllowAnyOrigin()
.AllowAnyHeader()
.AllowAnyMethod());



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
