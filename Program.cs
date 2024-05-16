using MicrosoftEntityFramework.Data;
using MicrosoftEntityFramework.Model;

AppDbContext? database = null;

try
{
    database = new AppDbContext();

    // database.User.Add(new MicrosoftEntityFramework.Model.User { EMail = "", Name = "" });
    if(database.User.Count() == 0) {
        database.User.Add(new User { EMail = "Angela.Gaugler@edu.fhdw.de", Name = "Angela Gaugler" });
        database.User.Add(new User { EMail = "Leonard.Kraus@edu.fhdw.de", Name = "Leonard Kraus" });
        database.User.Add(new User { EMail = "Timo.Behr@edu.fhdw.de", Name = "Timo Behr" });
        database.User.Add(new User { EMail = "Moritz.Wehlitz@edu.fhdw.de", Name = "Moritz Wehlitz" });
        database.User.Add(new User { EMail = "Lena.Kosmetschke@edu.fhdw.de", Name = "Lena Kosmetschke" });
    }

    // database.User.OrderBy(predicate);
    User lastAddedUser = database.User.OrderBy(a => a.UserID).Last();

    // database.User.Remove(User);
    database.User.Remove(lastAddedUser);

    database.SaveChanges();

    // Ausgabe aller Benutzer in der Konsole
    List<User> users = database.User.ToList();
    foreach (var user in users)
    {
        Console.WriteLine(
            user.UserID + ": " +
            user.Name + ", " +
            user.EMail + "."
        );
    }
    Console.ReadLine();
}
catch(Exception e)
{
    Console.WriteLine("Ein Fehler ist aufgetreten: {0}", e.Message);
}
finally
{
    if(database != null )
        database.Dispose();
}
