Array.prototype.contains = function(obj)
{
  var length = this.length;
  for(i=0;i<length;i++)
  {
    if(this[i] == obj)
      return true;
  }
  return false;
}

function updateWordChoices(char)
{
  var sentence = $("input[name=sentence]").val() + char;
  $(".wordOptions").html("");
  var uniqueWords = [];
  $.each(sentence.split(' '), function (index, word) {
    // alert(uniqueWords + " " + $.inArray(uniqueWords, word) + " " +word);
    var word2 = word.replace(/[^\w\s]|_/g, "");
    if(!uniqueWords.contains(word2) && word2.length > 0)
      uniqueWords.push(word2);
  });
  uniqueWords.forEach(function(word) {
    if(word.length > 0)
      $(".wordOptions").append('<div class="word">' + word + '</div>');
  });
  $(".word").each(function() {
    $(this).click(function() {
      $("#testWord").val($(this).text());
      $("#countRepeats").submit();
    })
  })
}
$(document).ready(function() {
  updateWordChoices('');
  $("input[name=sentence]").on("change keydown paste input", function(event) {
    if(event.which == 13)
    {
      event.preventDefault();
    }
    updateWordChoices(String.fromCharCode(event.which));
    
  });
});