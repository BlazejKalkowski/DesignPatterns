using Builder;

EmailSender emailWithoutAllProperties = new EmailMessageBuilder()
                              .AddSender("john.doe@gmail.com")
                              .AddBody("Welcome in Builder fluent pattern")
                              .Build();

EmailSender emailWithAllProperty = new EmailMessageBuilder()
                              .AddSender("john.doe@gmail.com")
                              .AddRecipient("micheal.m@gmail.com")
                              .AddSubject("Builder Pattern")
                              .AddBody("Welcome in Builder fluent pattern")
                              .Build();
