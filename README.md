# NIC Interview

## I would like you to only spend like 4 hours tops on this assignment. There may be more tasks than you can complete and that is ok.

## Please do not Google the solution you will find information but it will not help you that much and it defeats the purpose of the exercise. You may Google any thing else you need to solve the problem.

Notown Records has decided to store information about musicians who perform on its albums (as well as other company data) in a database. The company has wisely chosen to hire you as a system designer.
1. Each musician that records at Notown has an SSN, a name, an address, and a phone number. Poorly paid musicians often share the same address, and no address has more than one phone.
2. Each instrument used in songs recorded at Notown has a unique identification number, a name (e.g., guitar, synthesizer, flute) and a musical key (e.g., C, B-flat, E-flat).
3. Each album recorded on the Notown label has a unique identification number, a title, a copyright date, a format (e.g., CD or MC), and an album identifier.
4. Each song recorded at Notown has a title and an author.
5. Each musician may play several instruments, and a given instrument may be played by several musicians.
6. Each album has a number of songs on it, but no song may appear on more than one album.
7. Each song is performed by one or more musicians, and a musician may perform a number of songs.
8. Each album has exactly one musician who acts as its producer. A musician may produce several albums, of course.

Tasks
1. This is an MVC Core project, please instantiate the project as a C# .Net Core MVC project and include local authentication.
2. Create all models, controllers and views.
3. Verify that when creating, editing or deleting a record that all related data is also updated.
4. Configure the authentication:
  1. Passwords must require a digit, special character, upper, lower, length of 8, unique email address
  2. Any other security settings you feel appropriate
5. Configure Authorization
  1. Minimum a non logged in user can access an index view only
  2. Nice to have the links to created, edit and delete are hidden when not logged in
6. Add what ever cool stuff you think I might like as time permits, be sure to put it in your commit comments so I know what you added
7. Also comment in your committs anything you found to be confusing or you struggled with


