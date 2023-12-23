// Döngü: Aynı kod parçasının tekrar tekrar çalıştırılmasını sağlayan yapıya döngü denir.

//WHILE
// let a = 1;
// while (a <= 10) {
//     console.log(a);
//     a++;
// };

// 1-10 arasındaki çift sayıları konsola yazdırın.
// let i = 1;
// while (i <= 10) {
//     if (i % 2 == 0) {
//         console.log(i);
//     }
//     i++;
// };

// SORU:
// 1-50 arasındaki 4'ün katı olan sayıların adedini bulup konsola yazdırın.
// let i = 1;
// let counter = 0;
// while (i <= 50) {
//     if (i % 4 == 0) {
//         counter++;
//     }
//     i++;
// }
// console.log("1-50 arasındaki 4'ün katları olan sayı adedi: " + counter);

// Girilecek 3 adet sayıyı toplayıp, konsola yazdırın.
// let i = 1;
// let num;
// let total = 0;
// while (i <= 3) {
//     num = Number(prompt("Lütfen sayıyı giriniz:"));
//     // total = total + num;
//     total += num;
//     i++;
// }
// console.log(total);

// Kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp konsola yazan kodu yazınız. Not: Kullanıcı 0 girerse uygulama sona ersin.
// let i = 1;
// let total = 0;
// let num;
// while (true) {
//     num = Number(prompt("Lütfen bir sayı giriniz:"));
//     if (num == 0) {
//         break;
//     }
//     total += num;
// }
// console.log("Toplam: " + total);

// Kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp konsola yazan kodu yazınız. Not: Kullanıcı Exit yazarsa uygulama sona ersin.

// let i = 0;
// let total = 0;
// let num;

// while (true) {
//     num = prompt("Lütfen " + (i + 1) + ". sayıyı giriniz: (Çıkmak için 'Exit'!");

//     if (num.toLocaleLowerCase() == "exit") {
//         break;
//     }
//     total += Number(num);
//     i++;
// }

// console.log("Girdiğiniz " + i + " adet sayının toplamı: " + total);
// let count = Number(prompt("Lütfen bir sayı gir"));
// for (let i = 1; i <= count; i++) {
//     console.log(i);
// }

// 1-10 arasındaki çift sayıları konsola yazdırın.
// for (let i = 1; i <= 10; i++) {
//     if (i % 2 == 0) {
//         console.log(i);
//     }
// }

// for (let i = 1; i <= 10; i++) {
//     if (i % 2 == 0) {
//         continue;
//     }
//     console.log(i);
// }

// Kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp konsola yazan kodu yazınız. Not: Kullanıcı Exit yazarsa uygulama sona ersin. Not2: For kullanın.
// let total = 0;
// let num;
// for (let i = 0; i == 0;) {
//     num = prompt("Lütfen bir sayı giriniz: ");
//     if (num.toLocaleLowerCase() == "exit") {
//         break;
//     }
//     total += Number(num);
// }
// console.log(total);


/* 1-20 arasındaki sayıları konsola şu şekilde yazdıran kodu hazırlayınız:
    1-Tek Sayı
    2-Çift Sayı
    3-Tek Sayı
    4-Çift Sayı
    ...
    ...
    ...
*/


for (let i = 1; i <= 20; i++) {
    if (i % 2 == 0) {
        console.log(i + " - Çift Sayı");
    } else {
        console.log(i + " - Tek Sayı");
    }
}

