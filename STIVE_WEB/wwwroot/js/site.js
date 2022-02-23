// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function getTotalPrice() {
    let allCheckoutItems = document.querySelectorAll(".checkout-item .checkout-item-product-quantity-price-value")
    let arrayPrices = []

    allCheckoutItems.forEach(price => arrayPrices.push(price.textContent))

    let totalPrice = arrayPrices.reduce((partialSum, a) => partialSum + a, 0);

    console.log(totalPrice)
}

//Change le prix d'une commande en fonction de la quantitée commandée
$(".checkout-item-product-quantity-input").on('change', function () {
    let itemId = $(this).attr("data-itemId")
    let element = $(".checkout-item-" + itemId) 
    let unitPrice = $(element).find(".checkout-item-product-info-price-value").text().replace(",",".")
    let quantity = $(element).find(".checkout-item-product-quantity-input").val()
    let newPrice = unitPrice * quantity
    newPrice = parseFloat(newPrice).toFixed(2)
    $(element).find(".checkout-item-product-quantity-price-value").text(newPrice.toString().replace(".", ","))

    getTotalPrice()
})
