"use strict";

let students = ["ayşen", "umay", "ceyda", "begüm", "köfte", "heda"];

let result;

result = students.length;
result = students;
result = students.toString();
result = students.join(";");
result = result.split(";");

let products1 = ["Ürün1", "Ürün2", "Ürün3"];
let products2 = ["Ürün4", "Ürün5", "Ürün6"];

result = products1.concat(products2);

// students.push("Zeynep"); // Sona eleman ekler
// students.pop();//Son elemanı siler
// students.shift(); //İlk elemanı siler
// students.unshift("Ece");//Başa eleman ekler

// students dizisindeki 'ceyda' değerini taşıyan elemanın içeriğini 'ece' olarak değiştirin.
// let indexCeyda = students.indexOf("ceyda");
// students[indexCeyda] = "ece";
// students[students.indexOf("ceyda")] = "ece";

// students.splice(students.indexOf("ceyda"), 1);
result = students.splice(2, 3);
// result = students;


console.log(result);