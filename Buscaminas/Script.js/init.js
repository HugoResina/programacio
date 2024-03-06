function init() {
    let a = new Table(2, 2, 4);
    a.Print();
}

class Tile {
    tileType;//Bool
    neighbour;//Int
    positionX;
    positionY;
    covered;//bool

    constructor(positionX, positionY) {
        this.tileType = false;
        this.neighbour = 0;
        this.positionX = positionX;
        this.positionY = positionY;
        this.covered = true;
    }

    toString() {
        return "type {0}, neighbour {1}, position {2},{3}", this.tileType, this.neighbour, this.positionX, this.positionY
    }

}

class Table {
    board = [[]];
    maxX;
    maxY;
    constructor(x, y, mines) {
        this.board = this.GenerateBoard(x, y);
        this.maxX = x;
        this.maxY = y;
        console.log(this.board)
        this.GenerateMine(mines);
    }

    GenerateBoard(x, y) {
        let aux = [];
        for (let i = 0; i < x; i++) {
            aux.push([]);
            for (let j = 0; j < y; j++) {
                aux[i].push(new Tile(i, j));
            }
        }
        return aux;
    }
    GenerateMine(quantity) {
        let randomX;
        let randomY;
        for (let i = 0; i < quantity;) {
            randomX = Math.floor(Math.random() * this.maxX);
            randomY = Math.floor(Math.random() * this.maxY);
            console.log("coordenadas bomba",randomX, randomY);
            if (this.board[randomX][randomY].tileType == false) {
                i++;
                this.board[randomX][randomY].tileType = true;
                console.log(this.board);
                this.GenerateNeibourHood(randomX, randomY);
            }
        }
    }
    GenerateNeibourHood(x, y) {
        for (let i = x - 1; i < x + 2; i++) {
            for (let j = y - 1; j < y + 2; j++) {
                if (i >= 0 && j >= 0 && !(i == x && j == y)&&i < this.maxX && j < this.maxY) {
                    console.log("vacio",i,j);
                    console.log(this.board)
                    this.board[i][j].neighbour++;
                    console.log(this.board[i][j].neighbour)
                }
            }
        }
    }
    Print() {
        for (const tile of this.board) {
            console.log(tile);
        }
    }

    FLoodFill(x, y){
        //vailda respectivamente que: no sea bomba, no tenga vecinos, no este descubierta y que este en el rango de la matriz
        if (!this.board[x][y].tileType && this.board[x][y].neighbour == 0 && this.board[x][y].covered && (i >= 0 && j >= 0 && i < this.maxX && j < this.maxY)){
            this.board[x][y].covered = false;
            for(let i = x-1; i<x+2; i++){
                for(let j = y-1; j<y+2; j++){
                this.FLoodFill(i, j);
                }
            }
        }
    }
}