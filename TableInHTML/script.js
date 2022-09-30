$(document).ready(() => {
  getApiRickAndMorty();
  $("#backPage").hide();

  $("#backPage").on("click", () => {
    page--;
    if (page === 1) {
      $("#backPage").hide();
    } else if (page < countPages) {
      $("#nextPage").show();
    }
    createRowsTable(listCharacters[page]);
  });

  $("#nextPage").on("click", () => {
    page++;
    if (page === countPages) {
      $("#nextPage").hide();
    } else if (page > 1) {
      $("#backPage").show();
    }
    getApiRickAndMorty();
  });
});

listCharacters = [];
countPages = 0;
page = 1;

getApiRickAndMorty = () =>
  $.ajax({
    url: `https://rickandmortyapi.com/api/character/?page=${page}`,
    success: (response) => {
      if (countPages === 0) {
        countPages = response.pages;
      }
      listCharacters[page] = response.results;
      createRowsTable(listCharacters[page]);
    },
  });

createRowsTable = (data) => {
  let rows = "";

  data.forEach((row) => {
    rows += `
            <tr>
                <td><img src="${row.image}"></td>
                <td>${row.id}</td>
                <td>${row.name}</td>
                <td>${row.status}</td>
                <td>${row.species}</td>
                <td>${row.type}</td>
                <td>${row.gender}</td>
                <td>${row.created}</td>
            </tr>
        `;
  });

  $("#textNumberPage").text(page);
  $("#tableApiRickAndMorty tbody").empty().append(rows);
};
