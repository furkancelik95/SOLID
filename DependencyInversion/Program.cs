// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
/*
 * Dependency Inversion Principle
 * 
 * Büyük sistemler (matkap) küçük sistemlere (uç) bağlı olmak yerine
 * küçük sistemler büyük sistemlere aktarılmalıdır.
 */

ReportNotifier reportNotifier = new ReportNotifier();
reportNotifier.sender = new MailSender();


