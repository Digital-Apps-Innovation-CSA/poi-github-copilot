//sudoku on javascript and html
//validate sudoku game
// add button to validadte the game

// Create a 3x3 Sudoku board
let board = [
    [0, 0, 0],
    [0, 0, 0],
    [0, 0, 0]
];

// Function to create the Sudoku board in HTML
function createBoard() {
    let table = document.getElementById('sudoku');

    for (let i = 0; i < 3; i++) {
        let row = document.createElement('tr');

        for (let j = 0; j < 3; j++) {
            let cell = document.createElement('td');
            let input = document.createElement('input');
            input.type = 'text';
            input.value = board[i][j] === 0 ? '' : board[i][j];
            cell.appendChild(input);
            row.appendChild(cell);
        }

        table.appendChild(row);
    }
}

// Function to clear the Sudoku board
function clearBoard() {
    let table = document.getElementById('sudoku');

    for (let i = 0; i < 3; i++) {
        for (let j = 0; j < 3; j++) {
            table.rows[i].cells[j].firstChild.value = '';
        }
    }
}

function validateBoard() {
    // Update the board array with the current values in the HTML
    let table = document.getElementById('sudoku');

    for (let i = 0; i < 3; i++) {
        for (let j = 0; j < 3; j++) {
            let value = table.rows[i].cells[j].firstChild.value;
            board[i][j] = value === '' ? 0 : parseInt(value, 10);
        }
    }

    // Validate the board
    if (isValidSudoku(board)) {
        alert('The board is valid!');
    } else {
        alert('The board is not valid!');
    }
}
function isValidSudoku(board) {
    for (let i = 0; i < 9; i++) {
        let row = new Set(),
            col = new Set(),
            box = new Set();

        for (let j = 0; j < 9; j++) {
            let rowIndex = Math.floor(i / 3) * 3 + Math.floor(j / 3);
            let colIndex = i % 3 * 3 + j % 3;

            if (board[i][j] && row.has(board[i][j])) return false;
            if (board[j][i] && col.has(board[j][i])) return false;
            if (board[rowIndex][colIndex] && box.has(board[rowIndex][colIndex])) return false;

            row.add(board[i][j]);
            col.add(board[j][i]);
            box.add(board[rowIndex][colIndex]);
        }
    }
    return true;
}
// Create the Sudoku board when the page loads
window.onload = createBoard;