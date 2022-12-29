const loadMore = document.querySelector('.loadMore');
loadMore.addEventListener('click', loadMore);

function loadMore() {
    let serviceCount = $('.card').children().length
    fetch("/Work/LoadMore?skip" + serviceCount)

        .then(response => response.text())
        .then(text => {
            $('.card').append(text)
            lastCount = $(".card").children().length
            if (serviceCount + 4 > lastCount) {
                loadMore.remove();
            }
        })
}