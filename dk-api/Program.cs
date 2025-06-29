using dk_api.Interfaces;
using dk_api.Services;
using dkApi.Interfaces;
using dkApi.Repositories;
using dkApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//services
builder.Services.AddTransient<IInvestmentService, InvestmentService>();

//repo's
builder.Services.AddTransient<IUserInfoRepository, UserInfoRepository>();

//repo's
builder.Services.AddScoped<ICalculatorService, CalculatorService>();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddCors(options =>
    {

        options.AddDefaultPolicy(
            policy =>
            {
                policy.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
    });
}

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
