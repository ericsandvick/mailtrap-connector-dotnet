# MailTrap Connector
Mailtrap Connector is a .Net Standard 2.0 library that allows you to send emails via the MailTrap API.

<br/>

## :rocket: Getting Started

- Add a reference to MailTrapConnector.dll to your project.

<br/>

## :hammer: Usage

### Initializing the MailTrap service

```c#
MailTrapService mailTrapService = new MailTrapService(
    apiToken: "894a5a3a2b3c4e44b1e24291ce24bc9e",                // API token for your account.  Note that it is different between your test sandbox and live domains.
    sendUrl: "https://sandbox.api.mailtrap.io/api/send/1234567"  // API end-point URL.  Again this will be different between your test sandbox and live domains.
);
```

### Send a message using subject and body

```c#
// Initialize the message
MailTrapMessage mailTrapMessage = new MailTrapMessage
{
  From = new MailTrapFromEmail("hello@example.com", "Mailtrap Test"),
  ToEmails = new List<MailTrapToEmail>
  {
      new MailTrapToEmail("you@yourdomain.com")
  },
  Subject = "You are awesome!",
  Text = "Congrats for sending test email with Mailtrap!",
  Category = "Integration Test"
};

// Send the message and retrive the response
string response = mailTrapService.SendEmail(mailTrapMessage);
```

### Send a message using a template

```c#
// Initialize the message
MailTrapTemplateMessage mailTrapTemplateMessage = new MailTrapTemplateMessage
{
  From = new MailTrapFromEmail("hello@demomailtrap.com", "Mailtrap Test"),
  ToEmails = new List<MailTrapToEmail>
  {
    new MailTrapToEmail("you@yourdomain.com")
  },
  TemplateUuid = "30dfc268-321c-4d64-9264-c9d506299f77",

  // This is an object that you'll need to implement based on the variables defined in your template.
  TemplateVariables = new   
  {
    jobTitle = "Application Developer",
    location = "Remote" 
    languages = new List<object>
    {
      "C#",
      "Java",
      "Html"
    }
  }
};

// Send the message and retrive the response
string response = mailTrapService.SendEmail(mailTrapTemplateMessage);
```
