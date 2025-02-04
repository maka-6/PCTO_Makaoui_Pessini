let template_students = (item) => {
    return `<tr>
            <td>${item.id}</td>
            <td>${item.name}</td>
            <td>${item.surname}</td>
            <td>${item.classRoomId}</td>
            <td>${item.classRoomName}</td>
            </tr>`
};

fetch("/api/Student")
    .then(response => response.json())
    .then(data => InsertDataInTable(data));


let InsertDataInTable = (json) => {
    let rows = json.map(template_students).join('');
    document.getElementById('table_body').innerHTML = rows;
}