function ExecuteScript() {
    let element = document.querySelectorAll('input');
    for (let i = 0; i < element.length; i++) {
        if (element[i].name == 'login') {
            element[i].value = 'libanolimpeza';
        }
        else if (element[i].name == 'senha') {
            element[i].value = 'Limppa22';
        }
    }
}


function ExecuteScript() {
    return document.querySelector('[data-sitekey]').getAttribute('data-sitekey');
}


function ExecuteScript() {
    return window.location.href;
}

function ExecuteScript() {
    let element = document.querySelectorAll('input');
    for (let i = 0; i < element.length; i++) {
        if (element[i].name == 'login') {
            element[i].value = 'libanolimpeza';
        }
        else if (element[i].name == 'senha') {
            element[i].value = 'Limppa22';
        }
    }
}

// listUsuariosTable
(function() {
	let table = document.querySelector('#listUsuariosTable');
	let rows = table.querySelectorAll('tr');
	let data = [];
	for (let i = 1; i < rows.length; i++) {
		let row = rows[i];
		let cols = row.querySelectorAll('td');
        data.push({"Matricula": cols[0].innerText, "Nome": cols[1].innerText, "Cpf": cols[2].innerText, "Status": cols[3].innerText, "NrDoCartao": cols[4].innerText, "StatusBu": cols[5].innerText, "Pir": cols[6].innerText});
	}
	return JSON.stringify(data)
})();

(function() {
	let table = document.querySelector('#listUsuariosTable');
	let rows = table.querySelectorAll('tr');
	let data = [];
	for (let i = 1; i < rows.length; i++) {
		let row = rows[i];
		let cols = row.querySelectorAll('td');
        data.push({"Matricula": cols[0].innerText, "Nome": cols[1].innerText, "Cpf": cols[2].innerText, "Status": cols[3].innerText, "NrDoCartao": cols[4].innerText, "StatusBu": cols[5].innerText, "Pir": cols[6].innerText});
	}
	return JSON.stringify(data)
})();

(function() {
	let e=document.querySelector("#listUsuariosTable").querySelectorAll("tr"),t=[];for(let r=1;r<e.length;r++){let n=e[r].querySelectorAll("td");t.push({Matricula:n[0].innerText,Nome:n[1].innerText,Cpf:n[2].innerText,Status:n[3].innerText,NrDoCartao:n[4].innerText,StatusBu:n[5].innerText,Pir:n[6].innerText})}JSON.stringify(t)})();

//
!function(){let e=document.querySelector("#listUsuariosTable").querySelectorAll("tr"),t=[];for(let r=1;r<e.length;r++){let n=e[r].querySelectorAll("td");t.push({Matricula:n[0].innerText,Nome:n[1].innerText,Cpf:n[2].innerText,Status:n[3].innerText,NrDoCartao:n[4].innerText,StatusBu:n[5].innerText,Pir:n[6].innerText})}JSON.stringify(t)}();


(function() {
	let element = document.querySelector('input[type=file]');
    let teste = element.getBoundingClientRect();
    return {x: teste.left, y: teste.top};
})();

(function() {
	document.getElementById('escolhidoBoleto').click();
})();


    let element = document.querySelectorAll('input');
    for (let i = 0; i < element.length; i++) {
        element[i].click();
        }

function ExecuteScript(){let element=document.querySelectorAll('input');for(let i=0;i<element.length;i++)'login'==element[i].name?element[i].value='libanolimpeza':'senha'==element[i].name&&(element[i].value='Limppa22')}
let element=document.querySelectorAll('input');for(let i=0;i<element.length;i++)'login'==element[i].name?element[i].value='libanolimpeza':'senha'==element[i].name&&(element[i].value='Limppa22');

document.getElementById('campoStatusUsuario').value='',document.getElementById('tpFiltroUsuario').value=3,document.getElementById('campoPalavraChave').select();