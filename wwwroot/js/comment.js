document.getElementById("post_btn").addEventListener("click", postComment);

function postComment() {
    document.getElementById("comment_form").submit();

    let text = document.getElementById("comment_box").value;
    let section = document.getElementById("comments_container");
    let now = new Date()
    let date = now.toLocaleDateString();
    let time = now.getHours() + ":" + now.getMinutes();

    section.innerHTML += ("<p><span class=\"datetime\">" + date + ", " + time + "</span><br>" + text + "</p><hr>");
}