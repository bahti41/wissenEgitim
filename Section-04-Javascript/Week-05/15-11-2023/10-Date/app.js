let result;
let now;
now = new Date();
result = now;
result = now.getDate(); //günü verir
result = now.getDay();

// let newDate = new Date(2023, 5, 18);
// console.log(newDate);
// result = newDate.getDay();

result = now.getFullYear();
result = now.getHours();
result = now.getTime();

result = new Date(1900, 0, 1);
let year = result.getFullYear() + 3;
let month = result.getMonth();
let day = result.getDate();
result = new Date(year, month, day);

// console.log(result);

//-2208995816000
//-2208958016000

// Kaç gün yaşadığımızı bulan kod

let birthday = new Date(1975, 6, 16);
let milisecond = now - birthday;
let second = milisecond / 1000;
let minute = second / 60;
let hour = minute / 60;
let dayCount = hour / 24;
console.log(dayCount);
console.error(dayCount);
console.warn(dayCount);

// Araştırma Ödevi: getTime()'ı 0 olan tarih nedir? 