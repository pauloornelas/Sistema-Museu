using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using MuseuAPI.Services;
using MuseuAPI.Services.Interfaces;
using MuseuAPI.Data;
using MuseuAPI.Repositories;
using MuseuAPI.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Configuração da string de conexão com o PostgreSQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
                       ?? "Host=museupim.c1ieu0e08ts4.us-east-2.rds.amazonaws.com;Port=5432;Database=MuseuDB;Username=root;Password=97558604rsg";

// Configuração dos serviços
ConfigureServices(builder.Services, connectionString);

var app = builder.Build();

// Configuração do pipeline HTTP
ConfigurePipeline(app);

app.Run();

/// <summary>
/// Configura os serviços da aplicação
/// </summary>
void ConfigureServices(IServiceCollection services, string connectionString)
{
    // Banco de Dados
    services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

    // Injeção de Dependência
    services.AddScoped<IObraService, ObraService>();
    services.AddScoped<IQuestionarioService, QuestionarioService>();

    services.AddScoped<IObraRepository, ObraRepository>();
    services.AddScoped<IQuestionarioRepository, QuestionarioRepository>();

    // Controladores e Swagger
    services.AddControllers();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Museu Multitemático - Viagem a Marte",
            Version = "v1",
            Description = "API para gerenciar a exposição e o feedback dos visitantes"
        });

        // Configuração para incluir comentários XML
        var xmlFile = $"{System.AppDomain.CurrentDomain.FriendlyName}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath);
    });
}

/// <summary>
/// Configura o pipeline de execução da aplicação
/// </summary>
void ConfigurePipeline(WebApplication app)
{
    // Middleware de desenvolvimento
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Museu Multitemático v1");
        });
    }

    // Segurança e Controladores
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
}
