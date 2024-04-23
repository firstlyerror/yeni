


var telebe1={
   
    GroupName:"p232",
    Name:"ilkin",
    points:20,
}

var telebe2={  
    
    Name:"elvin",
    GroupName:"p232",
    points:40,}

var telebe3={

    Name:"Fuad",
    GroupName:"cs401",
    points:80,

}
var telebe4={

    Name:"fuad",
    GroupName:"p232",
    points:10,
}

var sum=0;
var telebeler=[telebe1,telebe2,telebe3,telebe4]

for (var i=0; i<telebeler.length;i++){

    var sum=sum+telebeler[i].points;
    var avg=sum/i;
 
}

console.log(avg)

console.log("------------------------------------------------------------------------------sd")

//Verilmiş maşınlar siyahısındaki ağ rəngli maşınların sayını tapan alqoritm
//  (hər bir maşın obyektinin brand,model və color xüsusiyyətləri var)

var car1={
    model:"mercedes",
    brand:"e220",
    color:"white",
}

var car2={
    model:"bmw",
    brand:"e220",
    color:"qara",
}

var car3={
    model:"hundai",
    brand:"e220",
    color:"white",
}
var count=0;
var car =[car1,car2,car3]

for(var i=0; i<car.length;i++)

{
if(car[i].color=="white")
{
    count++;
}


}
console.log(count)

console.log("------------------------------------------------------------------------------")

//Verilmiş ədədlər siyahısındaki  ən böyük ədədi tapan alqoritm

var a=[1,2,5,66,100,12,22,14,233,32,116]

max=a[0];

for (var i=0;i<a.length;i++)
{
    if(a[i]>max )
    {
        max=a[i];
     
 }
}
console.log(max) 
