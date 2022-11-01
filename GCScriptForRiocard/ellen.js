let nomes = ["Ellen", "Gustavo", "Tatiane", "Amanda", "Jefferson", "Soeli"];

for (let index = 0; index < nomes.length; index++) {
    // index começa em 0 e vai até o tamanho do array
    console.log( nomes[index]); 
}

console.log("-------------------------------------------------")

nomes.forEach(element => {
    console.log(element);
});

console.log("-------------------------------------------------")

console.log(nomes[4]);