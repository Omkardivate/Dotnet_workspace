// this is 'web'
using BLL;
using BOL;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!\nThis is Main page...");
app.MapGet("/welcome", () => "Welcome buddy...");

app.MapGet("/api/student", () => new {Id=230945920020, FirstName="Omkar",LaststName="Divate",Age=22 });

//To get data of all ProjectManager
app.MapGet("/api/activities", () => {
    List<Activity> items= ProjectManager.GetAll();
    return items;
});



// for those whose work is completed=true
app.MapGet("/api/activities/complete", ( ) =>{
    List<Activity> items= ProjectManager.GetAll();
    var manager= items.FindAll((manager)=> manager.IsComplete==true);
    return manager;
});

// to get data from url using id 
app.MapGet("/api/activities/{id}",   (int id) =>{
    List<Activity> items= ProjectManager.GetAll();
    var manager= items.Find((manager)=> manager.Id==id);
    return manager;
});
/*
app.MapPost("/api/activities", async (Activity Activity) =>
{
    return Results.Created($"/{Activity.Id}", Activity);
});

app.MapPut("/activities/{id}",   (int id, Activity inputActivity ) =>
{
    return Results.NoContent();
});

app.MapDelete("/api/pactivities/{id}", (int id ) =>
{
    return Results.NotFound();
});
*/
app.Run();
