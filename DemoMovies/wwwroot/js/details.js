function ValidateCommentField() {
    let comment = document.getElementById("comment").value;
    if (comment == null || comment == " ") {
        alert("Input field is required")
        return false;
    } else {
        return true;
    }
}

function AddLike(movieId) {
    axios.post('/MovieLike/AddLike/', {
        Id: movieId
    })
        .then(function (response) {

            let removeDislikeBtn = document.getElementById("btnRemoveDislike");

            if (!removeDislikeBtn.classList.contains("displayNone")) {
                DecreaseEngagementCount("movieDislikesCount");
                SwitchDisplay("btnAddDislike", "btnRemoveDislike");
            }

            IncreaseEngagementCount("movieLikesCount")
            SwitchDisplay("btnRemoveLike", "btnAddLike");
        })
        .catch(function (error) {
            console.log(error);
        });
}

function RemoveLike(movieId) {
    axios.post('/MovieLike/UnLike/', {
        Id: movieId
    })
        .then(function (response) {
            DecreaseEngagementCount("movieLikesCount");
            SwitchDisplay("btnAddLike", "btnRemoveLike");
        })
        .catch(function (error) {
            console.log(error);
        });
}

function AddDislike(movieId) {
    axios.post('/MovieLike/AddDislike/', {
        Id: movieId
    })
        .then(function (response) {

            let removeLikeBtn = document.getElementById("btnRemoveLike");

            if (!removeLikeBtn.classList.contains("displayNone")) {
                DecreaseEngagementCount("movieLikesCount");
                SwitchDisplay("btnAddLike", "btnRemoveLike");
            }

            IncreaseEngagementCount("movieDislikesCount");
            SwitchDisplay("btnRemoveDislike", "btnAddDislike");
        })
        .catch(function (error) {
            console.log(error);
        });
}

function RemoveDislike(movieId) {
    axios.post('/MovieLike/UnDislike/', {
        Id: movieId
    })
        .then(function (response) {
            DecreaseEngagementCount("movieDislikesCount");
            SwitchDisplay("btnAddDislike", "btnRemoveDislike");
        })
        .catch(function (error) {
            console.log(error);
        });
}

function IncreaseEngagementCount(elementId) {
    let likesContainer = document.getElementById(elementId);
    likesContainer.innerHTML = parseInt(likesContainer.innerHTML) + 1;
}

function DecreaseEngagementCount(elementId) {
    let likesContainer = document.getElementById(elementId);
    likesContainer.innerHTML = parseInt(likesContainer.innerHTML) - 1;
}

function SwitchDisplay(showElement, hideElement) {
    let showEl = document.getElementById(showElement);
    let hideEl = document.getElementById(hideElement);

    showEl.classList.remove("displayNone");
    hideEl.classList.add("displayNone");
}