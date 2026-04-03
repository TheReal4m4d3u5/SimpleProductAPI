var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// OpenAPI (new built-in version, NOT SwaggerGen)
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
app.MapOpenApi();
}

// Enable controllers (THIS is what activates /api/products)
app.MapControllers();

app.Run();





// 🟨 Node / Express
// const app = express();
// app.get("/api/products", (req, res) => {
//   res.json(products);
// });
// app.listen(3000);


// 🟦 ASP.NET (your project)
// var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddControllers();

// var app = builder.Build();

// app.MapControllers();

// app.Run();