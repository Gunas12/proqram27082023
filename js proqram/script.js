//Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın
/*let n = 49;
if (n == 0 || n == 1) {
    console.log(); ("eded ne sadedir ne murekkeb");
}
if (n == 2) {
    console.log("sadedir");
}
for (let i = 2; i * i <= n; i++) {
    if (n % i == 0) {
        console.log("eded murekkeb");
        break;
    }
    else {
        console.log("eded sadedir");
        break;
    }
}*/


//1 - dən N - ə qədər 3 və 5 - ə bölünən ədədləri ekrana yazdırin.
/*let n = 199;
for (let i = 1; i < n; i++) {
    //if (i % 3==0 && i % 5 == 0)
    if (i % 15 == 0) {
        console.log(i);
    }
}*/


//Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın.
let n = 11111;
let d = 0;
while (n > 1) {
    n = n / 10;
    console.log(n / 10);
    d++;
}
console.log(d);

