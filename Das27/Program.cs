using Das27.Cities;
using Das27.Enterprises;
using Das27.Habitant;
using Das27.Transport;
City Yerevan =new City();
Yerevan.MayorName = "Armen Armenyan";


Habitants habitant1=new Habitants("Vahe","Taroyan","AL035567");
Car bmw = new Car("F22", "55VT577", "15480874AV", 252);
Car mustang = new Car("Mustang", "55VA577", "54254515AB", 300);

bmw.CheckTax(252);
habitant1.AddProp(bmw);
habitant1.AddProp(mustang);
habitant1.CheckMyProp();

Habitants habitant2=new Habitants("Gago","Martirosyan","AA001122");
Car mercedes = new Car("C63","01KK001","251A51B",300);
habitant2.AddProp(mercedes);
habitant2.CheckMyProp();
mercedes.CheckTax(300);




Yerevan.AddInfo(habitant1);
Yerevan.AddInfo(habitant2);



Bus PublicBus = new Bus("ZongThong","0054","0001546A",300);
PublicBus.Move();
PublicBus.CheckTax(300);


Bank AEB = new Bank("AEB",22500);
AEB.AddEnterprise(Yerevan, AEB);
Bank AmeriaBank = new Bank("AmeriaBank", 32500);
AmeriaBank.AddEnterprise(Yerevan,AmeriaBank);

Yerevan.ChecEnterprisesInfo(AEB);

University Ufar = new University("UFAR", 250, 3450);
University AUA = new University("AUA", 300, 2500);

Ufar.AddUniverity(Yerevan, Ufar);
AUA.AddUniverity(Yerevan, AUA);

Yerevan.ChecEnterprisesInfo(Ufar);

//AEB.RemoveEnterprise(Yerevan, AEB);

//Yerevan.ChecEnterprisesInfo(AmeriaBank);
//Ufar.RemoveUniversity(Yerevan, Ufar);
//Yerevan.ChecEnterprisesInfo(AUA);



Yerevan.Datacheck();

AEB.BecomeClient(habitant1);
AmeriaBank.BecomeClient(habitant1);
AmeriaBank.BecomeClient(habitant2);
AEB.BecomeClient(habitant2);

//habitant1.CheckMyBanks();


AEB.Payment(habitant1);
AEB.Payment(habitant2);
AmeriaBank.Payment(habitant1);
AmeriaBank.Payment(habitant2);

AEB.CheckUserData();
AmeriaBank.CheckUserData();

/*AEB.RemoveClient(habitant1);
AEB.CheckUserData();*/

Yerevan.GetTax(habitant1, 250);

AEB.CheckUserData();
AmeriaBank.CheckUserData();


