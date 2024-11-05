using Microsoft.EntityFrameworkCore;
using TelephoneCompany.Infrastructure.Data;
using TelephoneCompany.Interfaces.Repositories;
using TelephoneCompany.Interfaces.Services;
using TelephoneCompany.Repositories;
using TelephoneCompany.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TelephoneCompanyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IClientService, ClientService>();

builder.Services.AddScoped<ITariffPlanRepository, TariffPlanRepository>();
builder.Services.AddScoped<ITariffPlanService, TariffPlanService>();

builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IServiceService, ServiceService>();

builder.Services.AddScoped<IClientTariffPlanRepository, ClientTariffPlanRepository>();
builder.Services.AddScoped<IClientTariffPlanService, ClientTariffPlanService>();

builder.Services.AddScoped<IClientServiceRepository, ClientServiceRepository>();
builder.Services.AddScoped<IClientServiceService, ClientServiceService>();

builder.Services.AddScoped<IRequestRepository, RequestRepository>();
builder.Services.AddScoped<IRequestService, RequestService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
