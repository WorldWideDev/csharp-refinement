# C# Refinement | Coding Dojo
## May, 2018

1) Intro/Overview DONE (Noelle)

2) Language Fundamentals DONE (Noelle)
    i. OOP (Noelle)

4) ASP.NET I : Controllers and Views (Noelle)
    i. routing
    ii. ViewResult/RedirectResult/JsonResult
        => Assignment: Something with JsonResult
    iii. Session
    iv. Controller <=> View Data Flow
        - ViewBag/ViewDataDictionary
        - ViewModels
        - Forms
        - Forms with Models (validation)
 
5) ASP.NET II Databases and Models (Devon)
    i. Services (Devon)
    ii. DBs w/ DbConnector
        => Assignment: Quoting Dojo
    iii. Dapper
    iv. EF
    <= BELT =>
    v. Identity

6) Deployment (Devon)
    i. AWS
    ii. Azure
### Emphesis on Service Injection

Dependency Injection with services is a central aspect of the ASP.NET stack, that is severely underrepesented with course materials.  This concept requires its own lesson module, complete with assignment(s) that cover the essential aspects:

- High-level understanding of how service injection works in the framework
- Understanding of how Controller objects are constructed
- Service life-spans [Scoped, Transient, Singleton]
- Revisted when dealing with Securing Connection Strings, Entity Framework (or possibly include lesson module right before/or within ORMs chapter)

### Emphesis on Debugging

Instant emphasis on debugging. This is not only the biggest advantage of the stack, but it is what makes the stack the most different compared to the other non-compiled stacks. Historically, students who learn how to debug with console writes do not immediately understand or want to debug live using VSCode and not enough emphasis on the why, how & how debugging makes their jobs easier. I’ve noticed it takes more than TWO WEEK before the student “gets it” about debugging and starts actually running their projects through the debugger rather than just running them in the terminal. Here are the needs:

In the only existing video for debugging, the top of the video is cut off, which means the student CANNOT SEE the debugging toolbar. This renders the video useless. Add lessons in debugging in a console app. Another lesson early in ASP.NET to show how to debug a web app. Excellent pair programming opportunity.

Explicitly cover these topics :

- Debugger vs Terminal/Command
- Breakpoints

- Starting the debugger

- Stepping (over, into, out)

- Variables (Locals)

- Watches

- Call Stack

### DB Connections, ORMS

Eliminate DBConnection related content, move into Dapper sooner as the first DB component, finishing with Entity Framework & more heavy emphasis on Code First. I’ve been witness to the pain students go through when you combine learning the ASP.NET Core middleware pipeline, and then switch the back ends from DBConnection, to Dapper, and to EF. To them that’s 4 moving parts. The combination of the pipeline, Dapper and EF and Code First is more than enough. 

More thoughts: 

- Possibly use Postgres instead of MySql throughout the track as it is compatible with Code First whereas MySql is not.

- Consider using SQL Server Express for Windows computers. This would complete the ecosystem, though this is probably a longer term goal.

- Teach ViewModels as the primary way to send data to/from back end & views. Students who are taught about the ViewBag, like console debugging, tend not to try ViewModels beyond the assignments they are presented with. They will stick with the ViewBag and overuse it and use it inappropriately. I’ve seen many belt exams that rely too heavily on ViewBag and not enough reliant on ViewModels.
 
- Emphasize how to get creative on modelling client data vs server side data. (Wrappers)

- The current approach of creeping commitment (heavy on ViewBag) leaves student confused.

- More emphasis on the Service Pipeline & Dependency Injection and how it works.

- Student who don’t understand the pipeline tend to build a “boilerplate” that they copy/paste as new assignments, thereby not learning what the pipeline is and how it is helping them.

- Move LINQ to the EF chapter, expound with better examples and lead into EF with it.

### Candyman

We would like to be able to maintain the Candyman package, and it would be a much better look in the eyes of students, if this was presented as an official Coding Dojo product.

- Move repo to official Coding Dojo github account.

### Deployment

- Currently the Azure steps are spread out and appear too early in the stack. Collect them into their own chapter and move them to the end of the stack.



