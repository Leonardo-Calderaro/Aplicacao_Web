
using Aplicação_Web.Servicos;
using Microsoft.EntityFrameworkCore;

var construtor = WebApplication.CreateBuilder(args);

// Add services to the container.
construtor.Services.AddRazorPages();
construtor.Services.AddDbContext<ContextoBD>(options =>
{
    var stringConexao = construtor.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(stringConexao);
});

var aplicacao = construtor.Build();

// Configure the HTTP request pipeline.
if (!aplicacao.Environment.IsDevelopment())
{
    aplicacao.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    aplicacao.UseHsts();
}

aplicacao.UseHttpsRedirection();

aplicacao.UseRouting();

aplicacao.UseAuthorization();

aplicacao.MapStaticAssets();
aplicacao.MapRazorPages().WithStaticAssets();

aplicacao.Run();
