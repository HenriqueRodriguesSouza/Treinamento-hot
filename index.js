class User {

    constructor(nome, email, password) {
        this.nome = nome;
        this.email = email;
        this.password = password;
    }

    validar() {
        return `O email é ${this.email} e a senha ${this.password} esta correta`

    }

}

const user1 = new User('pedro@teste.com', 'pedro123');
const user2 = new User('user2@example.com', 'securePassword');

console.log(user1.validar());
console.log(user2.validar());

    
class Curso extends User{

    constructor(nome, id, nomeCurso, valor, moeda) {
        super(nome);
        this.id = id;
        this.nomeCurso = nomeCurso;
        this.valor = valor;
        this.moeda = moeda;
    }

    info(){
        return `O curo id ${this.id} de nome ${this.nomeCurso} no valor de ${this.valor} ${this.moeda} pertence a ${this.nome}`
    }
}

const curso1 = new Curso('Paula', 1, 'vendas', 14.00, 'BRL')
const curso2 = new Curso('Carlos' ,2, 'aulas', 15.00, 'USD')

console.log(curso1.info());
console.log(curso2.info());