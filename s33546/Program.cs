using s33546;

var laptop1 = new Laptop("Asus ZenBook 300", 16, "Intel Core i5");
var laptop2 = new Laptop("Acer Predator 500", 32, "AMD Ryzen 9");
var laptop3 = new Laptop("Lenovo gaming X", 16, "Intel Core i7");
var laptop4 = new Laptop("HP JobMaster", 64, "Intel Core i9");
var camera1 = new Camera("Canon EOS1", 24.5, 3);
var camera2 = new Camera("Canon PowerShot2", 40.0, 50);
var camera3 = new Camera("Canon PRO", 16.2, 10);
var camera4 = new Camera("Canon Mega", 32.0, 5);
var projector1 = new Projector("Cool Projectorek", "4K", 3.5);
var projector2 = new Projector("WhiteWall 2000", "1080p", 2.1);
var projector3 = new Projector("Inimanimo Pro X", "720p", 2.8);
var projector4 = new Projector("LightForge Titan", "16K", 7.2);

var employe = new Employee("Jonh","Doe","CEO");
var student = new Student("Jacob","Doe","IT");

var service = new RentalService();
service.AddDevice(laptop1);
service.AddDevice(laptop2);
service.AddDevice(laptop3);
service.AddDevice(laptop4);
service.AddDevice(camera1);
service.AddDevice(camera2);
service.AddDevice(camera3);
service.AddDevice(camera4);
service.AddDevice(projector1);
service.AddDevice(projector2);
service.AddDevice(projector3);
service.AddDevice(projector4);
service.ShowAvaibleDevices();

//Employee
service.RentDevice(employe,laptop1,DateTime.Now, DateTime.Now.AddDays(1));
//BŁĄD
service.RentDevice(employe,laptop1,DateTime.Now, DateTime.Now.AddDays(1));
service.RentDevice(employe,laptop2,DateTime.Now, DateTime.Now.AddDays(1));
service.RentDevice(employe,laptop3,DateTime.Now, DateTime.Now.AddDays(1));
service.RentDevice(employe,laptop4,DateTime.Now, DateTime.Now.AddDays(1));
service.RentDevice(employe,camera1,DateTime.Now, DateTime.Now.AddDays(1));
//BŁĄD
service.RentDevice(employe,camera2,DateTime.Now, DateTime.Now.AddDays(1));

service.ShowAvaibleDevices();

//Student
service.RentDevice(student,camera3,DateTime.Now, DateTime.Now.AddDays(1));
service.RentDevice(student,camera4,DateTime.Now, DateTime.Now.AddDays(1));
//BŁĄD
service.RentDevice(student,projector1,DateTime.Now, DateTime.Now.AddDays(1));
