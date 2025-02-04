let template_students = (item) => {
    return `<tr>
            <td><pre>   </pre></td>
            <td>${item.id}</td>
            <td>${item.name}</td>
            <td>(${item.price}€)</td>
            </tr>`
};

fetch("/api/viaggio")
    .then(response => response.json())
    .then(data => InsertDataInTable(data));


let InsertDataInTable = (json) => {
    let rows = json.map(template_students).join('');
    document.getElementById('table_body').innerHTML = rows;
}