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
    if(!uniqueWords.contains(word) && word.length > 0)
      uniqueWords.push(word);
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