using Microsoft.Extensions.DependencyInjection.Extensions;
using SoapCore;
using System.ServiceModel;
using WebServiceDemo.Service;
using WebServiceDemo.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//-----start----
builder.Services.TryAddSingleton<IScadaOperate, ScadaService>();
builder.Services.TryAddSingleton<IMesOperate, MesService>();
//-----end----


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
//https://localhost:7205/Scada/ScadaService.asmx
((IApplicationBuilder)app).UseSoapEndpoint<IScadaOperate>("/Scada/ScadaService.asmx", new BasicHttpBinding(),SoapSerializer.XmlSerializer);
//https://localhost:7205/Mes/MesService.asmx
((IApplicationBuilder)app).UseSoapEndpoint<IMesOperate>("/Mes/MesService.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
