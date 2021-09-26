# p411-26-sep-21

### Keçdiyimiz mövzuları təkrarlayın, videolara baxa-baxa yazdığımız kodları yenidən özünüz yazın (ki, əliniz öyrəşsin). Həmçinin keçmiş mövzulardan zəiflikləriniz varsa videoları izləyin sual yaranarsa qurupda bildirin.


#### Oxu üçün linklər:

https://www.w3schools.com/cs/cs_oop.php
https://www.w3schools.com/cs/cs_classes.php
https://www.w3schools.com/cs/cs_class_members.php
https://www.w3schools.com/cs/cs_constructors.php
https://www.w3schools.com/cs/cs_inheritance.php
https://www.w3schools.com/cs/cs_polymorphism.php


#### Tapşırıqlar (Hər tapşırıq ayrı proyektdə yazılmalıdır. Sonda hər iki proyekti bir folder-ə atıb eyni repoya push edərsiz.) (Tapşırıqları yazmamışdan əvvəl tam oxuyun, əvvəlcə tam başa düşün, real dünyadakı nümunələrini ağlınıza gətirin.):

- Motored vehicles
	- Motored vehicle classı olsun.
	- Car, Motorcycle, Boat classları olsun və bu classlar motored vehicle clasından inherit alsın.
	- Model, Make, ProductionYear, MotorSize, FuelTankSize, FuelAmount, FuelUsedPerKm, Color, Transmission, HorsePower, PassangerCount kimi fieldləri lazımi formada yerləşdirin. (Base classa və ya inherit alan classlardan hər hasınasa yerləşdirməyə özünüz qərar verin.) (Əlavə fieldlər də yaza bilərsiniz.) 
	- Motored vehicle classının 2 ctor-u olsun. Biri parameterless. Digəri Model, Make və year qəbul etsin, fieldləri set etsin.
    - Motored vehicle classının GetInfo və GetDetailedInfo metodları olsun və bu metodlar adlarına müvafiq funksiyaları yerinə yetirsin.
	- Car classının Model, Make və year qəbul edən 1 ctor-u olsun. Və qəbul etdiyi parametrləri inherit aldığı classın uyğun ctor-una "chain" etsin.
    - Car classının IsOn fieldi və TurnOn TurnOff metodları olsun. IsOn maşının çalışıb çalışmadığını ifadə edir metodlar isə bu fieldə müvafiq dəyişiklikləri edir.
    - Car classının Go metodu olsun. Bu metod məsafə qəbul edəcək və əgər göndərilən məsafəni getmək üçün kifayət qədər yanacaq varsa "** km məsafə qət edildi" qaytaracaq əks halda isə "Kifayət qədər yanacaq yoxdur". Həmçinin maşın işə salınmayıbsa gedə bilməz.
    - Car classı Motored vehicle classının GetDetailedInfo metodunu override edib FuelAmount fieldini də burada qaytarsın.

- Facebook?
    - User classı olsun. (Name, Surname, Email, DateOfBirth, isSingle ect.)
    - Bu classın parametrlərini sizin müəyyən edəcəyiniz 3 constructoru olsun.
    - Post classı olsun. (Text, SharedDate, LikeCount, CommentCount ect.)
    - Comment classı olsun. (Text, CommentedDate ect.)
    - Userin Postları olsun. (Post Arrayı tipindən)
    - Postun Commentləri olsun. (Comment Arrayı tipindən)
    - Commentin Useri olsun. (User tipindən) (Kommenti yazan Useri ifadə edəcək)