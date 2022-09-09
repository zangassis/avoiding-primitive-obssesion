using BadExample.Models;
using BadExample.Services;

var customer = new Customer("John", "john@123.mail.com", "997979821", true);
decimal productValue = 100;

CustomerService.ServiceProcess(customer, productValue);