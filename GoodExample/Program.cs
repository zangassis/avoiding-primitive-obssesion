using GoodExample.Models;
using GoodExample.Services;

var customer = new Customer("John", "john@123.mail.com", "997979821", new ClubMember(true));
decimal productValue = 100;

CustomerService.ServiceProcess(customer, productValue);
