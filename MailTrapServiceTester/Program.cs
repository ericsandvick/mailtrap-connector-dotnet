// See https://aka.ms/new-console-template for more information
using MailTrapConnector.Models;
using MailTrapConnector.Services;
using Newtonsoft.Json;

// Initialize a MailTrapService instance
MailTrapService mailTrapService = new MailTrapService(
    apiToken: "6f457db6a3980149c3b5bf10250edf6c",
    sendUrl: "https://sandbox.api.mailtrap.io/api/send/3397312");

// Initialize the message
//MailTrapMessage mailTrapMessage = new MailTrapMessage
//{
//    From = new MailTrapFromEmail("hello@example.com", "Mailtrap Test"),
//    ToEmails = new List<MailTrapToEmail>
//    {
//        new MailTrapToEmail("esandvick@hotmail.com")
//    },
//    Subject = "You are awesome!",
//    Text = "Congrats for sending test email with Mailtrap!",
//    Category = "Integration Test"
//};

//string json = JsonConvert.SerializeObject(mailTrapMessage);
//Console.WriteLine(json);

//// Send the message and retrive the response
//string response = mailTrapService.SendEmail(mailTrapMessage);
//Console.WriteLine(response);

MailTrapTemplateMessage mailTrapTemplateMessage = new MailTrapTemplateMessage
{
    From = new MailTrapFromEmail("hello@demomailtrap.com", "Mailtrap Test"),
    ToEmails = new List<MailTrapToEmail>
        {
            new MailTrapToEmail("esandvick@hotmail.com")
        },
    TemplateUuid = "30dfc268-321c-4d64-9264-c9d506299f77",
    TemplateVariables = new
    {
        teeTimes = new List<object>
        {
            new { dateTime = "2022-01-01T12:00:00", url = "https://reservations.arcadiabluffs.com/#/golfBooking/location/100/001/2022-01-01" },
            new { dateTime = "2022-01-01T12:30:00", url = "https://reservations.arcadiabluffs.com/#/golfBooking/location/100/001/2022-01-01" }
        }
    }
};


string json = JsonConvert.SerializeObject(mailTrapTemplateMessage);
Console.WriteLine(json);


// Send the message and retrive the response
string response = mailTrapService.SendEmail(mailTrapTemplateMessage);
Console.WriteLine(response);
