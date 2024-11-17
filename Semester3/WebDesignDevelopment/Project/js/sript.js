const main = document.getElementById('root');

// Use fetch to get data from the API
fetch('./json/data.json')
    .then(function (response) {
        return response.json();
    })
    .then(data => {
        // // Begin accessing JSON data here
        data.items.forEach(item => {

            //Creating card
            const card = document.createElement('div');
            card.setAttribute('class', 'card col-md-3 px-0');
            card.setAttribute('style', 'width: 19rem')

            //Card body
            const cardBody = document.createElement('div');
            cardBody.setAttribute('class', 'card-body');

            //Card banner
            const banner = document.createElement('img');
            banner.src = item.banner;
            banner.setAttribute('class', 'card-img-top');

            //Card heading
            const cardHeading = document.createElement('h5');
            cardHeading.setAttribute('class', 'card-title');
            cardHeading.textContent = `${item.establishmentName}`;
            
            //Opening hours
            const cardOpeningHours = document.createElement('p');
            cardOpeningHours.setAttribute('class', 'fw-light');
            cardOpeningHours.textContent = `Delivery Hours: ${item.deliveryHours}`;

            //Card text
            const cardText = document.createElement('p');
            cardText.setAttribute('class', 'card-text');
            cardText.textContent = `${item.description.substring(0,50)}...`;

            //Card button
            const cardButton = document.createElement('a');
            cardButton.setAttribute('class', 'btn btn-primary');
            cardButton.setAttribute('href', '#');
            cardButton.textContent = 'View';

            //Card appending
            shopDisplay.appendChild(card);
            card.appendChild(banner);
            card.appendChild(cardBody);
            cardBody.appendChild(cardHeading);
            cardBody.appendChild(cardOpeningHours);
            cardBody.appendChild(cardText);
            cardBody.appendChild(cardButton);
        });
    })
    .catch(function (error) {
        // Handle any errors from the fetch operation
        // const errorMessage = document.createElement('marquee');
        // errorMessage.textContent = `Gah, it's not working! Error: ${error.message}`;
        // main.appendChild(errorMessage);
    });
