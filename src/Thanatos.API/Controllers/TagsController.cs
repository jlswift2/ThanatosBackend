
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateTagRequestResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateTag([FromBody] CreateTagBody body)
        {
            var result = await _mediator.Send(new CreateTagRequest(body));
            return CreatedAtAction(nameof(GetTag), new { id = result.Id }, result);
        }
