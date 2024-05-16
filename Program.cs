using MicrosoftEntityFramework.Data;

AppDbContext database = new AppDbContext();

//database.User.Add(new MicrosoftEntityFramework.Model.User{ EMail = "marc.pape-info@web.de", Name = "Marc" });
//database.User.Add(new MicrosoftEntityFramework.Model.User{ EMail = "yannic.bruegger-info@web.de", Name = "Yannic" });
//database.User.Remove(database.User.OrderBy(a => a.UserID).Last());
//database.SaveChanges();

//database.User.Add(new MicrosoftEntityFramework.Model.User { EMail = "Jonas.Knewitz@edu.bib.de", Name = "Jonas Knewitz", UserID=3 });
//database.User.Remove(database.User.OrderBy(a => a.UserID).Last());
//database.SaveChanges();

var users = database.User.ToList();

foreach  (var user in users) { 
    Console.WriteLine(
        user.Name + ", " + 
        user.EMail + ", " + 
        user.UserID + '.'
    ); 
}
Console.ReadLine();

database.Dispose();