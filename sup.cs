public class User
{
    [Key]
    public int UserId {get;set;}
    public string Name {get;set;}
    public string Email {get;set;}
}
public class Message
{
    [Key]
    public int MessageId {get;set;}
    public string Content {get;set;}
    public int UserId {get;set;}
    public User Creator {get;set;}
}