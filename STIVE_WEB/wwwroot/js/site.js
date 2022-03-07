$(document).ready(function () {
    if (window.location.pathname == "/Cart/Checkout") {

        //Récupère tous les items du panier et calcul le montant total de la commande
        function getTotalPrice() {
            let allCheckoutItems = document.querySelectorAll(".checkout-item .checkout-item-product-quantity-price-value")
            let totalPrice = 0;

            allCheckoutItems.forEach(
                item => totalPrice += parseFloat(item.innerHTML.replace(",", "."))
            )

            document.querySelector(".checkout-price .checkout-price-total-product").innerHTML = "Produits: " + totalPrice.toFixed(2) + " €"
            document.querySelector(".checkout-price .checkout-price-total").innerHTML = "Total: " + totalPrice.toFixed(2) + " €"

            return totalPrice.toFixed(2)
        }
        getTotalPrice()

        function buildOrderString() {
            let allCheckoutItems = document.querySelectorAll(".checkout-item")
            let jsonArray = []

            allCheckoutItems.forEach(function (item) {
                let articleId = $(item).find(".checkout-item-product-quantity-input").attr("data-itemid")
                let unitPrice = $(item).find(".checkout-item-product-info-price-value").text()
                let quantity = $(item).find(".checkout-item-product-quantity-input").val()

                json = {
                    "articleId": articleId,
                    "unitPrice": unitPrice.replace(",", "."),
                    "quantity": quantity
                }

                jsonArray.push(json)
            })

            
            $("#order").val(JSON.stringify(jsonArray))

            console.log($("#order").val())
        }

        //Change le prix d'une commande en fonction de la quantitée commandée
        $(".checkout-item-product-quantity-input").on('change', function () {
            let itemId = $(this).attr("data-itemId")
            let element = $(".checkout-item-" + itemId)
            let unitPrice = $(element).find(".checkout-item-product-info-price-value").text().replace(",", ".")
            let quantity = $(element).find(".checkout-item-product-quantity-input").val()
            let newPrice = unitPrice * quantity
            newPrice = parseFloat(newPrice).toFixed(2)
            $(element).find(".checkout-item-product-quantity-price-value").text(newPrice.toString().replace(".", ","))

            getTotalPrice()
            buildOrderString()
        })




    }

    $("#btn-order").on('click', function () {
        $("#order-form").submit()
    })
    


})
