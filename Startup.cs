using AdidataDbContext.Models.MySql.Auth;
using AdidataDbContext.Models.MySql.Recruitment;
using AdidataDbContext.Models.MySql.Hrm;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.Text;
using Newtonsoft.Json.Serialization;

namespace BasicProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            services.AddDbContext<RecruitmentContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("Recruitment"),
                Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb")));


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Recruitment API Services", Version = "v1" });

                var securitySchema = new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };
                c.AddSecurityDefinition("Bearer", securitySchema);

                var security = new OpenApiSecurityRequirement();
                security.Add(securitySchema, new[] { "Bearer" });
                c.AddSecurityRequirement(security);
            });

            //add cors
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromMinutes(15);

            });

            services.AddControllersWithViews()
   .AddNewtonsoftJson(options =>
   options.SerializerSettings.ReferenceLoopHandling = Newtonsoft
   .Json.ReferenceLoopHandling.Ignore)
   .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver
   = new CamelCasePropertyNamesContractResolver());



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddHttpContextAccessor();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/basic/swagger/v1/swagger.json", "Dokumen");
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Dokumen");
                c.DocumentTitle = "Documentation";
                c.DocExpansion(DocExpansion.List);
            });



            app.UseRouting();
            app.UseCors("AllowAll");
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}